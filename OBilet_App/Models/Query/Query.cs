namespace WebApplication1.Models
{
    public class Query
    {
        #region private
        private string m_SessionID = "";
        private string m_DeviceID = "";
        private string m_StartPoint = "";
        private string m_StartPointText = "";
        private string m_EndPoint = "";
        private string m_EndPointText = "";
        private string m_Date = "";
        #endregion
        #region public
        public string SessionID { get { return m_SessionID; } set { m_SessionID = value; } }
        public string DeviceID { get { return m_DeviceID; } set { m_DeviceID = value; } }
        public string StartPoint { get { return m_StartPoint; } set { m_StartPoint = value; } }
        public string StartPointText { get { return m_StartPointText; } set { m_StartPointText = value; } }
        public string EndPoint { get { return m_EndPoint; } set { m_EndPoint = value; } }
        public string EndPointText { get { return m_EndPointText; } set { m_EndPointText = value; } }
        public string Date { get { return m_Date; } set { m_Date = value; } }
        #endregion
    }
}
