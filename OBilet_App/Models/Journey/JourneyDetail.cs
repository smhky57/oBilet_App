namespace WebApplication1.Models
{
    public class JourneyDetail
    {
        #region private
        private int m_OriginID = 0;
        private int m_DestinationID = 0;
        private string m_StartHour = "";
        private string m_EndHour = "";
        private string m_StartPoint = "";
        private string m_EndPoint = "";
        private string m_Price = "";
        #endregion
        #region public
        public int OriginID { get { return m_OriginID; } set { m_OriginID = value; } }
        public int DestinationID { get { return m_DestinationID; } set { m_DestinationID = value; } }
        public string StartHour { get { return m_StartHour; } set { m_StartHour = value; } }
        public string EndHour { get { return m_EndHour; } set { m_EndHour = value; } }
        public string StartPoint { get { return m_StartPoint; } set { m_StartPoint = value; } }
        public string EndPoint { get { return m_EndPoint; } set { m_EndPoint = value; } }
        public string Price { get { return m_Price; } set { m_Price = value; } }
        #endregion
    }
}
