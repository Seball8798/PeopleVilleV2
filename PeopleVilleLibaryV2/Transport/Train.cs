using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleVilleLibraryV2.Transport
{
    public class Train : Transport
{
    public string Location { get; set; }

    public override string Drive() 
    {
        Random rnd = new Random();
        int retningA = rnd.Next(1, 7);

        switch (retningA)
        {
                case 1:  
                    return "From St Odense";
                case 2:
                    return  "From St Ondesvej";
                case 3:
                    return "From St Ringsvej";
                case 4:
                    return "From St Lunekovvej";
                case 5:
                    return "From St Blommevej";
                case 6:
                    return "From St Ballørup";
                case 7:
                    return "From St Ryparken";
            }
            return "";
        }

        public  override string Stop() 
        {
            Random rnd = new Random();
            int retningStop = rnd.Next(1, 7);

            switch (retningStop)
            {
                case 1:
                    return("Stop St Odense");
                case 2:
                    return ("Stop St Ondesvej");
                case 3:
                    return ("Stop Ringsvej");
                case 4:
                    return ("Stop St Lunekovvej");
                case 5:
                    return ("Stop St Blommevej");
                case 6:
                    return ("Stop St Ballørup");
                case 7:
                    return ("Stop St Ryparken");
            }
            return "";
        }
    }
}

