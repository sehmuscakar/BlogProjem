using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Sehmus.BusinessLayer.Abstract;
using Sehmus.EntitiesLayer.Concrete;


namespace Sehmus.PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPortfolioService _portfolioService;
        private readonly IBlogService _blogService;
        private readonly IContactPostService _contactPostService;
        public HomeController(IPortfolioService portfolioService, IBlogService blogService, IContactPostService contactPostService)
        {
            _portfolioService = portfolioService;
            _blogService = blogService;
            _contactPostService = contactPostService;
        }
        public async Task<IActionResult> Anasayfa() // Analayouta bağlı olan kısımlar burdamn çekilecek zaten
        {
            return View();
        }
        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Information()
        {
            return View();
        }
        public IActionResult Portfolio(int id)
        {

            var resultDataId = _portfolioService.GetByID(id);
            return View(resultDataId);
        }
        public IActionResult PortfolioList()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }

        public IActionResult Blog(int id)
        {
            var resultDataId = _blogService.BlogGetByIdService(id);
            return View(resultDataId);
        }
        public IActionResult BlogList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactPost contactPost)
        {
            //gönderilecek olan kişin bilgileri
            MimeMessage mimeMessage = new MimeMessage();// minekit kütüphanesi eklemen lazım bunun için maile doğrulama yapmak için 

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Web'ten Mesajınız", "sehmuscakar33@gmail.com");//kimden geleceği isim ve mail

            mimeMessage.From.Add(mailboxAddressFrom);//kimden gelecek ekle
                                                     //alacak olan kişin bilgileri
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", contactPost.Mail);//kime gideği isim ve adres

            mimeMessage.To.Add(mailboxAddressTo);//kime gidecek ekle

            //  mimeMessage.Subject = contact.Subject;// bu direk mail başlığında yazar
            mimeMessage.Subject = "Şehmus Çakar Blog Site";// bu direk mail başlığında yazar

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Gönderen Adı: " + contactPost.Name + "***" + "Konu: " + contactPost.Subject + "***" + "Gönderilen Mesaj: " + contactPost.Message;
            mimeMessage.Body = bodyBuilder.ToMessageBody();   //mesaja ekle body kısmına 

            //mimeMessage.Subject = "Easy Cash Onay Kodu";//konu kısmı

            SmtpClient client = new SmtpClient();// mail trnsfer nesne örneği protokol
            client.Connect("smtp.gmail.com", 587, false);//prokol gereklikleri bağlantı kurma ,burda bağlatı güvenliğine false dedik çünkü ConfirmMailController da true işlemi yapacaz emailconfirmed

            client.Authenticate("sehmuscakar33@gmail.com", "yvbuojwjmbaqxkck");//mail ve mailde oluşturduğun güvenlik kodu,bunu her bir ayrı projede ayrı al bu güvenlik kodunu mail üzerinden bazı işlmlerle alırsın
            client.Send(mimeMessage);//gönder
            client.Disconnect(true);//gövenli çıkış yap 
                                    //bu işlemi yapman için iki adımlı doğrulamyı mail de açman lazım
            _contactPostService.Add(contactPost);
            ViewBag.SuccessMessage = "Mesajınız Başarılı bir Şekilde Gönderildi";
            return View();

        }

    }
}