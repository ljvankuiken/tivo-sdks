﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Net;

namespace Tivo.Hmo
{
    public class TivoVideo : TivoItem
    {
        private TivoVideo(XElement element)
            : base(element)
        {
            if (!ContentTypes.IsVideo(ContentType))
                throw new FormatException(Properties.Resources.ArgumentNotVideo);
        }

        public static explicit operator TivoVideo(XElement element)
        {
            return new TivoVideo(element);
        }

        public static explicit operator TivoVideo(XDocument document)
        {
            return new TivoVideo(document.Root);
        }

        /// <summary>
        /// Size of video in bytes
        /// </summary>
        public long Length
        {
            get { return GetLength(Element); }
        }

        public TimeSpan Duration
        {
            get { return GetDuration(Element); }
        }

        public DateTimeOffset Captured
        {
            get { return GetCaptured(Element); }
        }

        public CustomIcon CustomIcon
        {
            get
            {
                return GetCustomIcon(Element);
            }
        }

        public string EpisodeTitle
        {
            get
            {
                return GetEpisodeTitle(Element);
            }
        }

        public string Description
        {
            get
            {
                return GetDescription(Element);
            }
        }

        public string SourceChannel
        {
            get
            {
                return GetSourceChannel(Element);
            }
        }

        public string SourceStation
        {
            get
            {
                return GetSourceStation(Element);
            }
        }

        public TivoVideoDetails TivoVideoDetails
        {
            get
            {
                return GetTivoVideoDetails(Element);
            }
        }

        protected static long GetLength(XElement tivoItem)
        {
            return (long)tivoItem.Element(Calypso16.Details).Element(Calypso16.SourceSize);
        }

        protected static TimeSpan GetDuration(XElement tivoItem)
        {
            return TimeSpan.FromMilliseconds((int)tivoItem.Element(Calypso16.Details).Element(Calypso16.Duration));
        }

        protected static DateTimeOffset GetCaptured(XElement tivoItem)
        {
            return DateUtility.ConvertHexEpochSeconds((string)tivoItem.Element(Calypso16.Details).Element(Calypso16.CaptureDate));
        }

        protected static CustomIcon GetCustomIcon(XElement tivoItem)
        {
            var customIconElement = tivoItem.Element(Calypso16.Links).Element(Calypso16.CustomIcon);
            if (customIconElement == null)
                return null;
            return new CustomIcon(customIconElement);
        }

        protected static string GetEpisodeTitle(XElement tivoItem)
        {
            return (string)tivoItem.Element(Calypso16.Details).Element(Calypso16.XNamespace + "EpisodeTitle");
        }

        protected static string GetDescription(XElement tivoItem)
        {
            return (string)tivoItem.Element(Calypso16.Details).Element(Calypso16.XNamespace + "Description");
        }

        protected static string GetSourceChannel(XElement tivoItem)
        {
            return (string)tivoItem.Element(Calypso16.Details).Element(Calypso16.XNamespace + "SourceChannel");
        }

        protected static string GetSourceStation(XElement tivoItem)
        {
            return (string)tivoItem.Element(Calypso16.Details).Element(Calypso16.XNamespace + "SourceStation");
        }

        protected static TivoVideoDetails GetTivoVideoDetails(XElement tivoItem)
        {
            var tivoVideoDetailsElement = tivoItem.Element(Calypso16.Links).Element(Calypso16.TiVoVideoDetails);
            if (tivoVideoDetailsElement == null)
                return null;
            return new TivoVideoDetails(tivoVideoDetailsElement);
        }
    }
}
