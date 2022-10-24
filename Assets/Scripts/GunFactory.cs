using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGunFactory
{
    IGun Create(GunSpecifications specs);
}

public class USSRFactory : IGunFactory
{
    public IGun Create(GunSpecifications specs)
    {
        if (specs.Period == "Old")
        {
            if (specs.Type == "Semi")
            {
                return new Makarov();
            }
            else
            {
                return new PPSh();
            }
        }
        else
        {
            if (specs.Type == "Semi")
            {
                return new SVD();
            }
            else
            {
                return new AK74();
            }
        }
    }
}

public class AmericanFactory : IGunFactory
{
    public IGun Create(GunSpecifications specs)
    {
        if (specs.Period == "Old")
        {
            if (specs.Type == "Semi")
            {
                return new M1Garand();
            }
            else
            {
                return new Tompson();
            }
        }
        else
        {
            if (specs.Type == "Semi")
            {
                return new Remington700();
            }
            else
            {
                return new M249();
            }
        }
    }
}

public class GermanFactory : IGunFactory
{
    public IGun Create(GunSpecifications specs)
    {
        if (specs.Period == "Old")
        {
            if (specs.Type == "Semi")
            {
                return new Luger();
            }
            else
            {
                return new MP38();
            }
        }
        else
        {
            if (specs.Type == "Semi")
            {
                return new Glock();
            }
            else
            {
                return new MP5();
            }
        }
    }
}

public abstract class AbstractGunFactory
{
    public abstract IGun Create();
}

public class GunFactory : AbstractGunFactory
{
    private readonly IGunFactory _factory;
    private readonly GunSpecifications _specs;

    public GunFactory(GunSpecifications specs)
    {
        if (specs.Country == "USSR")
        {
            _factory = new USSRFactory();
        }
        else if (specs.Country == "American")
        {
            _factory = new AmericanFactory();
        }
        else
        {
            _factory = new GermanFactory();
        }
        _specs = specs;
    }

    public override IGun Create()
    {
        return _factory.Create(_specs);
    }
}