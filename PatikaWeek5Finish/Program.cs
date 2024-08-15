using PatikaWeek5Finish;

Console.WriteLine("Araba oluşturmak istiyorsanız e istemiyorsanız h yazabilirsiniz");

string reply = Console.ReadLine().ToLower();
Text://goto yapabilmek için
if (reply == "e")
{
    
    List<Cars> car  = new List<Cars>(); // araba classını kullanarak arabalar listesi oluşt
   bool control = false;
    while (!control)
    {
        Cars list2 = new Cars();//farkli değerleri bir liste de toplamak list2  oluşturuyorum
       list2.date = DateTime.Now;

        Console.WriteLine("Arabanın seri numarasını giriniz ");//seri numarası ataması
        list2.carNumber=Console.ReadLine();

        Console.WriteLine("Arabanın markasını giriniz"); //marka ataması
        list2.brand = Console.ReadLine();

        Console.WriteLine("Arabanın modelini giriniz");//model ataması
        list2.model = Console.ReadLine();

        Console.WriteLine("Arabanın rengini giriniz");//renk ataması
        list2.colour = Console.ReadLine();

        bool control2=false;//while döngüsü için tanımlandı
        while (!control2)
        {
            Console.WriteLine("Arabanın kapı sayısını giriniz");
            string number = Console.ReadLine();
            try
            {
                // kapı sayısının geçersi girişlerinde hata belirterek işlemi yarım bırakmaması için bir kontrol oluşturuldu
                list2.doorNumber = int.Parse(number);//parse ile dönüşüm olur ise sayı girişi olduğun karar verilecek
                control2 = true;// eğer bu adımam gelir ise döngüden çıkacak
            }
            catch 
            {
                Console.WriteLine("Geçersiz giriş yaptınız sayı girişi yapınız");
            }
        }
        car.Add(list2);// list2 dekki verilleri arabalar listesine aktarıyorum
        text2:// goto yapabilmek için 
        Console.WriteLine("Tekrar bir araba oluşturmak istermiziniz (e/h)");
        string  reply2= Console.ReadLine();
        if (reply2 == "e")
        {

        }
        else if (reply2 == "h")
        {
            Console.WriteLine("Siparişiniz için teşekkür ederiz\nSiparişleriniz listesi:");
            foreach (Cars a in car)
            {
                Console.WriteLine(a);//seri numarası ve model listesini yazdırma
            }
            break;
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız");
            goto text2;//hatalı giriş yapılma durummunda if tekrarlayabilmek için 
        }

    }

}
else if ( reply=="h")
{
    Console.WriteLine("Teşekkürler");
}else
{
    Console.WriteLine("Geçersiz giriş yaptınız");
    goto Text;
}
