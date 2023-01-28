//erişim belirteci-geri dönüs tipi-metot_adı(parametrelistesi/arguman)  
//komutalr
//return
int a =2;
int b =4;
Console.WriteLine(a+b);
 
int sonuc =Topla(a,b);
Console.WriteLine(sonuc);

 Metotlar ornek= new Metotlar();
 ornek.Ekranayazdır(Convert.ToString(sonuc));


 int sonuc2=ornek.ArttırveTopla(ref a,ref b);
 ornek.Ekranayazdır(Convert.ToString(sonuc2));
 ornek.Ekranayazdır(Convert.ToString(a+b));


 


int Topla(int deger1,int  deger2)
{
    return (deger1+deger2);
}



class  Metotlar
{
   public void Ekranayazdır(string veri)
   {
Console.WriteLine(veri);
   }

    public int ArttırveTopla(ref int deger1,ref int deger2)
    {
         deger1+=1;
         deger2+=1;
         return deger1+deger2;
    }

}