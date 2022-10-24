using System.Collections.Specialized;
using System.Runtime.Versioning;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [Header("Specs")]
    public string Period;
    public string Country;
    public string Type;
    public IGun G;

    [Header("Dropdown")]
    public Dropdown Per;
    public Dropdown Cou;
    public Dropdown Typ;

    [Header("Summon")]
    public Text summon;

    void Update()
    {
        if (Per.value == 0)
        {
            Period = "Old";
        }
        else
        {
            Period = "Modern";
        }
        if (Cou.value == 0)
        {
            Country = "USSR";
        }
        else if (Cou.value == 1)
        {
            Country = "American";
        }
        else
        {
            Country = "German";
        }
        if (Typ.value == 0)
        {
            Type = "Semi";
        }
        else
        {
            Type = "Auto";
        }
        
        GunSpecifications specs = new GunSpecifications();
        specs.Country = Country;
        specs.Period = Period;
        specs.Type = Type;

        IGun gun = GetGun(specs);
        G = gun;
    }

    public void ButtonPress()
    {
        summon.text = G.ToString();
        if (summon.text == "AK74")
        {
            Instantiate(Resources.Load("AK74"));
        }
        else if (summon.text == "M249")
        {
            Instantiate(Resources.Load("M249"));
        }
        else if (summon.text == "Makarov")
        {
            Instantiate(Resources.Load("Makarov"));
        }
        else if (summon.text == "Glock")
        {
            Instantiate(Resources.Load("Glock"));
        }
        else if (summon.text == "Makarov")
        {
            Instantiate(Resources.Load("Makarov"));
        }
        else if (summon.text == "MP38")
        {
            Instantiate(Resources.Load("MP38"));
        }
        else if (summon.text == "PPSh")
        {
            Instantiate(Resources.Load("PPSh"));
        }
        else if (summon.text == "Tompson")
        {
            Instantiate(Resources.Load("Tompson"));
        }
        else if (summon.text == "MP5")
        {
            Instantiate(Resources.Load("MP5"));
        }
        else if (summon.text == "Luger")
        {
            Instantiate(Resources.Load("Luger"));
        }
        else if (summon.text == "Remington700")
        {
            Instantiate(Resources.Load("Remington700"));
        }
        else if (summon.text == "SVD")
        {
            Instantiate(Resources.Load("SVD"));
        }
        else
        {
            Instantiate(Resources.Load("M1Garand"));
        }

    }

    public static IGun GetGun(GunSpecifications specs)
    {
        GunFactory factory = new GunFactory(specs);
        return factory.Create();
    }

}
