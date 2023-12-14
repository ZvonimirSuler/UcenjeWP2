using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("E02")]
    public class E02VarijableTipoviPodatakaOperatori : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            //vratite najmanji broj
            return int.MinValue;
        }

        [HttpGet]
        [Route("zad2")]
        public float Zad2(int i, int j)
        {
            //ruta vraća kvocijent dvaju primljenih brojeva
            return (float)i / j;

        }
    }
    

    [HttpGet]
    [Route("zad3")]
    public float Zad3(int i, int j)
    {
        //ruta vraća zboj umnoška i kvocijent primljenih brojeva
        var umnozak = i * j; // var je ključna riječ koja preuzima tip podatka s desne strane znaka jednako
        var kvocijent = (float)i / j;
        return umnozak + kvocijent;

    }

    [HttpGet]
    [Route("zad4")]
    public string Zad4(string s, string s1)
    {
        // ruta vraća spojene primljene znakove
        return s + s1;
    
    }
}





