﻿

namespace Application.Configuration.Interfaces
{
    public interface IProperties
    {
        string DbStringConnection { get; }
        string EncrypKey { get; }
        string Nonce { get; }
    }
}
