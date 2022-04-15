using BlazingLego.Data.Models;

namespace BlazingLego.Data.Services;

public class LegoService {
    
    public List<LegoSet> GetOwnedLegoSets(){
    
        List<LegoSet> legoSets = new List<LegoSet>();

        string baseUrl = "https://www.lego.com/en-nl/product";
    
        legoSets.Add (new LegoSet{
            Id = 11,
            SetNumber = "10300",
            Description = "back to the future Time Machine",
            Acquired = "2022",
            Image = "/assets/10300.png",
            Pieces = "1872",
            Price = "€ 160,-",
            Link = $"{baseUrl}/back-to-the-future-time-machine-10300"
        });
        legoSets.Add (new LegoSet{
            Id = 10,
            SetNumber = "10295",
            Description = "Porsche 911",
            Acquired = "2021",
            Image = "/assets/10295.png",
            Pieces = "1458",
            Price = "€ 140,-",
            Link = $"{baseUrl}/porsche-911-10295"
        });
        legoSets.Add (new LegoSet{
            Id = 9,
            SetNumber = "10220",
            Description = "T1 Campervan",
            Acquired = "2020",
            Image = "/assets/10220.png",
            Pieces = "1332",
            Price = "€ 100,-",
            Link = $"{baseUrl}/volkswagen-t1-camper-van-10220"
        });
        legoSets.Add (new LegoSet{
            Id = 8,
            SetNumber = "10270",
            Description = "Bookshop",
            Acquired = "2020",
            Image = "/assets/10270.png",
            Pieces = "2504",
            Price = "€ 160,-",
            Link = $"{baseUrl}/bookshop-10270"
        });
        legoSets.Add (new LegoSet{
            Id = 7,
            SetNumber = "10243",
            Description = "Parisian Restaurant",
            Acquired = "2019",
            Image = "/assets/10243.png",
            Pieces = "2469",
            Price = "€ 160,-",
            Link = $"{baseUrl}/parisian-restaurant-10243"
        });
        legoSets.Add (new LegoSet{
            Id = 6,
            SetNumber = "10246",
            Description = "Detective's Office",
            Acquired = "2018",
            Image = "/assets/10246.png",
            Pieces = "2262",
            Price = "€ 160,-",
            Link = $"{baseUrl}/detective-s-office-10246"
        });
        legoSets.Add (new LegoSet{
            Id = 5,
            SetNumber = "10265",
            Description = "Ford Mustang",
            Acquired = "2017",
            Image = "/assets/10265.png",
            Pieces = "1471",
            Price = "€ 140,-",
            Link = $"{baseUrl}/ford-mustang-10265"
        });
        legoSets.Add (new LegoSet{
            Id = 4,
            SetNumber = "10258",
            Description = "London Bus",
            Acquired = "2015",
            Image = "/assets/10258.png",
            Pieces = "1686",
            Price = "€ 140,-",
            Link = $"{baseUrl}/london-bus-10258"
        });
        legoSets.Add (new LegoSet{
            Id = 3,
            SetNumber = "10242",
            Description = "Mini Cooper",
            Acquired = "2014",
            Image = "/assets/10242.png",
            Pieces = "1077",
            Price = "€ 100,-",
            Link = $"{baseUrl}/mini-cooper-10242"
        });
        legoSets.Add (new LegoSet{
            Id = 2,
            SetNumber = "10252",
            Description = "Volkswagen Beetle",
            Acquired = "2013",
            Image = "/assets/10252.png",
            Pieces = "1167",
            Price = "€ 100,-",
            Link = $"{baseUrl}/volkswagen-beetle-10252"
        });
        legoSets.Add (new LegoSet{
            Id = 1,
            SetNumber = "10220",
            Description = "T1 Campervan",
            Acquired = "2011",
            Image = "/assets/10220.png",
            Pieces = "1332",
            Price = "€ 100,-",
            Link = $"{baseUrl}/volkswagen-t1-camper-van-10220"  
        });

        legoSets.Add (new LegoSet{
            Id = 11,
            SetNumber = "10255",
            Description = "Assembly Square",
            Acquired = "No",
            Image = "/assets/10255.png",
            Pieces = "4002",
            Price = "€ 260,-",
            Link = $"{baseUrl}/assembly-square-10255"
        });
        legoSets.Add (new LegoSet{
            Id = 12,
            SetNumber = "10279",
            Description = "Volkswagen T2 Camper Van",
            Acquired = "No",
            Image = "/assets/10279.png",
            Pieces = "2207",
            Price = "€ 160,-",
            Link = $"{baseUrl}/volkswagen-t2-camper-van-10279"
        });
        legoSets.Add (new LegoSet{
            Id = 9,
            SetNumber = "21330",
            Description = "LEGO® Ideas Home Alone",
            Acquired = "No",
            Image = "/assets/21330.png",
            Pieces = "3955",
            Price = "€ 250,-",
            Link = $"{baseUrl}/lego-ideas-home-alone-21330"
        });

        return legoSets;
    }
}