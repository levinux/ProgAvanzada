using System;
using System.Diagnostics;

class NumerosPseudoaleatorios
{
  static void Main(string[] args)
  {
    long c = 0;
    long i = 0;
    float x = 0;
    Vars v = new Vars();
    Console.WriteLine("Cuantos numeros aleatorios quieres? ");
    c = Convert.ToInt32(Console.ReadLine());
    x = v.X0;

    do
    {
      x = (float) Math.Pow(GenerateRandom(x, v.C, v.A, v.M), -1) * 1000;
      Console.WriteLine("Numero aleatorio: {0}", x);
      i++;
    } while(i < c);
  }

  static float GenerateRandom(float x, long c, long a, long m)
  {
    /*
     * Hay que sustituir ese return por el codigo matematico necesario
     * para generar el siguiente numero aleatorio de acuerdo al metodo
     * Congruencial...
     */
    return -1000;
  }
}

class Vars
{
  private long a;
  private long m;
  private long c;
  private float x0;

  public float X0
  {
    get { return x0; }
  }

  public long A
  {
    get { return a; }
  }

  public long M
  {
    get { return m; }
  }

  public long C
  {
    get { return c; }
  }

  public Vars()
  {
    DateTime now = DateTime.Now;
    c = Stopwatch.GetTimestamp() % 7161;
    a = (now.Millisecond > 0) ? now.Millisecond * c : 10;
    m = (now.Second > 1) ? now.Second * a : 2;
    x0 = (a + c) % m;
  }
}
