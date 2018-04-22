using IMNWebService.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMNWebService
{
    public class PronosticoTiempo
    { }


    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class EFEMERIDES
    {

        private EFEMERIDESEFEMERIDE_SOL eFEMERIDE_SOLField;

        private EFEMERIDESEFEMERIDE_LUNA eFEMERIDE_LUNAField;

        private EFEMERIDESFASELUNAR fASELUNARField;

        /// <remarks/>
        public EFEMERIDESEFEMERIDE_SOL EFEMERIDE_SOL
        {
            get
            {
                return this.eFEMERIDE_SOLField;
            }
            set
            {
                this.eFEMERIDE_SOLField = value;
            }
        }

        /// <remarks/>
        public EFEMERIDESEFEMERIDE_LUNA EFEMERIDE_LUNA
        {
            get
            {
                return this.eFEMERIDE_LUNAField;
            }
            set
            {
                this.eFEMERIDE_LUNAField = value;
            }
        }

        /// <remarks/>
        public EFEMERIDESFASELUNAR FASELUNAR
        {
            get
            {
                return this.fASELUNARField;
            }
            set
            {
                this.fASELUNARField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EFEMERIDESEFEMERIDE_SOL
    {

        private string sALEField;

        private string sEPONEField;

        /// <remarks/>
        public string SALE
        {
            get
            {
                return this.sALEField;
            }
            set
            {
                this.sALEField = value;
            }
        }

        /// <remarks/>
        public string SEPONE
        {
            get
            {
                return this.sEPONEField;
            }
            set
            {
                this.sEPONEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EFEMERIDESEFEMERIDE_LUNA
    {

        private string sALEField;

        private string sEPONEField;

        /// <remarks/>
        public string SALE
        {
            get
            {
                return this.sALEField;
            }
            set
            {
                this.sALEField = value;
            }
        }

        /// <remarks/>
        public string SEPONE
        {
            get
            {
                return this.sEPONEField;
            }
            set
            {
                this.sEPONEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EFEMERIDESFASELUNAR
    {

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PRONOSTICO_PORCIUDADES
    {

        private string fECHAField;

        private string cOMENTARIOField;

        private PRONOSTICO_PORCIUDADESCIUDAD[] cIUDADESField;

        /// <remarks/>
        public string FECHA
        {
            get
            {
                return this.fECHAField;
            }
            set
            {
                this.fECHAField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIO
        {
            get
            {
                return this.cOMENTARIOField;
            }
            set
            {
                this.cOMENTARIOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CIUDAD", IsNullable = false)]
        public PRONOSTICO_PORCIUDADESCIUDAD[] CIUDADES
        {
            get
            {
                return this.cIUDADESField;
            }
            set
            {
                this.cIUDADESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_PORCIUDADESCIUDAD
    {

        private decimal tEMPMAXField;

        private decimal tEMPMINField;

        private PRONOSTICO_PORCIUDADESCIUDADESTADOTARDE eSTADOTARDEField;

        private PRONOSTICO_PORCIUDADESCIUDADESTADONOCHE eSTADONOCHEField;

        private string cOMENTARIOTARDEField;

        private string cOMENTARIONOCHEField;

        private byte idRegionField;

        private string nombreField;

        private byte idField;

        /// <remarks/>
        public decimal TEMPMAX
        {
            get
            {
                return this.tEMPMAXField;
            }
            set
            {
                this.tEMPMAXField = value;
            }
        }

        /// <remarks/>
        public decimal TEMPMIN
        {
            get
            {
                return this.tEMPMINField;
            }
            set
            {
                this.tEMPMINField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_PORCIUDADESCIUDADESTADOTARDE ESTADOTARDE
        {
            get
            {
                return this.eSTADOTARDEField;
            }
            set
            {
                this.eSTADOTARDEField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_PORCIUDADESCIUDADESTADONOCHE ESTADONOCHE
        {
            get
            {
                return this.eSTADONOCHEField;
            }
            set
            {
                this.eSTADONOCHEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOTARDE
        {
            get
            {
                return this.cOMENTARIOTARDEField;
            }
            set
            {
                this.cOMENTARIOTARDEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIONOCHE
        {
            get
            {
                return this.cOMENTARIONOCHEField;
            }
            set
            {
                this.cOMENTARIONOCHEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte idRegion
        {
            get
            {
                return this.idRegionField;
            }
            set
            {
                this.idRegionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_PORCIUDADESCIUDADESTADOTARDE
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_PORCIUDADESCIUDADESTADONOCHE
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PRONOSTICO_REGIONAL
    {

        private string fECHAField;

        private object cOMENTARIOField;

        private PRONOSTICO_REGIONALREGION[] rEGIONESField;

        /// <remarks/>
        public string FECHA
        {
            get
            {
                return this.fECHAField;
            }
            set
            {
                this.fECHAField = value;
            }
        }

        /// <remarks/>
        public object COMENTARIO
        {
            get
            {
                return this.cOMENTARIOField;
            }
            set
            {
                this.cOMENTARIOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("REGION", IsNullable = false)]
        public PRONOSTICO_REGIONALREGION[] REGIONES
        {
            get
            {
                return this.rEGIONESField;
            }
            set
            {
                this.rEGIONESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGION
    {

        private PRONOSTICO_REGIONALREGIONESTADOMADRUGADA eSTADOMADRUGADAField;

        private PRONOSTICO_REGIONALREGIONESTADOMANANA eSTADOMANANAField;

        private PRONOSTICO_REGIONALREGIONESTADOTARDE eSTADOTARDEField;

        private PRONOSTICO_REGIONALREGIONESTADONOCHE eSTADONOCHEField;

        private string cOMENTARIOMANANAField;

        private string cOMENTARIOTARDEField;

        private string cOMENTARIONOCHEField;

        private string cOMENTARIOMADRUGADAField;

        private PRONOSTICO_REGIONALREGIONCIUDAD[] cIUDADESField;

        private byte idRegionField;

        private string nombreField;

        /// <remarks/>
        public PRONOSTICO_REGIONALREGIONESTADOMADRUGADA ESTADOMADRUGADA
        {
            get
            {
                return this.eSTADOMADRUGADAField;
            }
            set
            {
                this.eSTADOMADRUGADAField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_REGIONALREGIONESTADOMANANA ESTADOMANANA
        {
            get
            {
                return this.eSTADOMANANAField;
            }
            set
            {
                this.eSTADOMANANAField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_REGIONALREGIONESTADOTARDE ESTADOTARDE
        {
            get
            {
                return this.eSTADOTARDEField;
            }
            set
            {
                this.eSTADOTARDEField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_REGIONALREGIONESTADONOCHE ESTADONOCHE
        {
            get
            {
                return this.eSTADONOCHEField;
            }
            set
            {
                this.eSTADONOCHEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOMANANA
        {
            get
            {
                return this.cOMENTARIOMANANAField;
            }
            set
            {
                this.cOMENTARIOMANANAField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOTARDE
        {
            get
            {
                return this.cOMENTARIOTARDEField;
            }
            set
            {
                this.cOMENTARIOTARDEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIONOCHE
        {
            get
            {
                return this.cOMENTARIONOCHEField;
            }
            set
            {
                this.cOMENTARIONOCHEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOMADRUGADA
        {
            get
            {
                return this.cOMENTARIOMADRUGADAField;
            }
            set
            {
                this.cOMENTARIOMADRUGADAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CIUDAD", IsNullable = false)]
        public PRONOSTICO_REGIONALREGIONCIUDAD[] CIUDADES
        {
            get
            {
                return this.cIUDADESField;
            }
            set
            {
                this.cIUDADESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte idRegion
        {
            get
            {
                return this.idRegionField;
            }
            set
            {
                this.idRegionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONESTADOMADRUGADA
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONESTADOMANANA
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONESTADOTARDE
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONESTADONOCHE
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONCIUDAD
    {

        private decimal tEMPMAXField;

        private decimal tEMPMINField;

        private PRONOSTICO_REGIONALREGIONCIUDADESTADOMANANA eSTADOMANANAField;

        private PRONOSTICO_REGIONALREGIONCIUDADESTADOTARDE eSTADOTARDEField;

        private PRONOSTICO_REGIONALREGIONCIUDADESTADONOCHE eSTADONOCHEField;

        private PRONOSTICO_REGIONALREGIONCIUDADESTADOMADRUGADA eSTADOMADRUGADAField;

        private string cOMENTARIOMANANAField;

        private string cOMENTARIOTARDEField;

        private string cOMENTARIONOCHEField;

        private string cOMENTARIOMADRUGADAField;

        private string nombreField;

        private byte idField;

        /// <remarks/>
        public decimal TEMPMAX
        {
            get
            {
                return this.tEMPMAXField;
            }
            set
            {
                this.tEMPMAXField = value;
            }
        }

        /// <remarks/>
        public decimal TEMPMIN
        {
            get
            {
                return this.tEMPMINField;
            }
            set
            {
                this.tEMPMINField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_REGIONALREGIONCIUDADESTADOMANANA ESTADOMANANA
        {
            get
            {
                return this.eSTADOMANANAField;
            }
            set
            {
                this.eSTADOMANANAField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_REGIONALREGIONCIUDADESTADOTARDE ESTADOTARDE
        {
            get
            {
                return this.eSTADOTARDEField;
            }
            set
            {
                this.eSTADOTARDEField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_REGIONALREGIONCIUDADESTADONOCHE ESTADONOCHE
        {
            get
            {
                return this.eSTADONOCHEField;
            }
            set
            {
                this.eSTADONOCHEField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_REGIONALREGIONCIUDADESTADOMADRUGADA ESTADOMADRUGADA
        {
            get
            {
                return this.eSTADOMADRUGADAField;
            }
            set
            {
                this.eSTADOMADRUGADAField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOMANANA
        {
            get
            {
                return this.cOMENTARIOMANANAField;
            }
            set
            {
                this.cOMENTARIOMANANAField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOTARDE
        {
            get
            {
                return this.cOMENTARIOTARDEField;
            }
            set
            {
                this.cOMENTARIOTARDEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIONOCHE
        {
            get
            {
                return this.cOMENTARIONOCHEField;
            }
            set
            {
                this.cOMENTARIONOCHEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOMADRUGADA
        {
            get
            {
                return this.cOMENTARIOMADRUGADAField;
            }
            set
            {
                this.cOMENTARIOMADRUGADAField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONCIUDADESTADOMANANA
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONCIUDADESTADOTARDE
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONCIUDADESTADONOCHE
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_REGIONALREGIONCIUDADESTADOMADRUGADA
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }





}

