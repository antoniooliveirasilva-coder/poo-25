public class Televisao
{


    public Televisao (float tamanho)
{
    Tamanho = tamanho;
}
    public float Tamanho { get;}
    public int resolucao { get; set; }
    public int volume { get; set; }
    public int canal { get; set; }
    public bool estado { get; set; } 
    
    public void aumentarvolume()
    {
       volume = Volume + 1; 
    }


}