namespace Intellidesk.AcadNet.Common.Enums
{
    public enum eDBObjectStatus
    {
        /// <summary>
        /// �������� ������ ����� ObjectId, �������� �������� 
        /// IsErased ������� ����� false
        /// </summary>
        NotErased,
        /// <summary>
        /// �������� ������ ����� ObjectId, �������� �������� 
        /// IsErased ������� ����� true
        /// </summary>
        Erased,
        /// <summary>
        /// �������� ��� ObjectId, �� �������� �� ��������
        /// �������� IsErased
        /// </summary>
        Any
    }
}