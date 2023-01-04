// See https://aka.ms/new-console-template for more information

int result = Topla(5,4);

Metodlar ornek = new Metodlar();
ornek.EkranaYazdir(result.ToString());

 int Topla (int deger1, int deger2){

    return (deger1 + deger2);
}

int a=5;
int b=4;
int sonuc=ornek.IncreaseAndAdd(ref a,ref b);

ornek.EkranaYazdir(Convert.ToString(a+b));
ornek.EkranaYazdir(Convert.ToString(sonuc));

class Metodlar {

    public void EkranaYazdir ( string message){

        Console.WriteLine(message);
    }

    public int IncreaseAndAdd( ref int deger1 , ref int deger2){

        deger1++;
        deger2++;
        return (deger1+ deger2);

    }

}