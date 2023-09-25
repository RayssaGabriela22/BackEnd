class animal
{
    public string cor { get; set; }

    public void EmitiSom()
    {
        Console.WriteLine("Animal omitindo som");
    }

}
class cachorro : animal
{
  public string tipoPelo { get; set; }

  public virtual void Latir(){
    Console.WriteLine($" O cachorro {cor} está latindo");
  }
}
class Gato : animal
{
    public override void EmitiSom()
    {
        Console.WriteLine($"Ogato esta miando");
    }
}
class program
{
    public static void Main()
    {
       // animal animalGerenerico = new animal();
        //animalGerenerico.EmitiSom();

        cachorro meuCachorro = new cachorro();
        meuCachorro.cor = "Caramelo";
        meuCachorro.EmitiSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitiSom();
    }
}
//polimorfismo é o poder de sobescrever algo pelo a classe pai
//a herança é quando você adquiri os atributos da classe pai.
//o filho pega os atributos da classe pai.
