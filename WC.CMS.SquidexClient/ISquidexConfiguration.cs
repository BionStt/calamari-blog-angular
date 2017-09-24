﻿namespace WC.CMS.SquidexClient
{
    public interface ISquidexConfiguration
    {
        string ApplicationName { get; }

        string ServiceURL { get; }

        string AuthServiceURL { get; }

        string ClientID { get; }

        string ClientSecret { get; }
    }
}