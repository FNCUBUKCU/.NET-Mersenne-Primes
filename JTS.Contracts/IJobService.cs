using System.ServiceModel;

namespace JTS.Contracts
{
    [ServiceContract]
    public interface IJobService
    {
        [OperationContract]
        long GetNewJob(string mac);

        [OperationContract]
        void SaveJobResult(string mac, long n, bool isPrime);
    }
}
