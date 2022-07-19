using api_sample.DataTransferObjects;

namespace api_sample.Interfaces;

public interface ISalesOrderServices
{
    void CreateItem(SalesOrderForCreateDto salesOrderForCreate);
    void UpdateItem(string docNumber, SalesOrderForUpdateDto salesOrderForUpdate);
    void DeleteItem(string docNumber);
    void GetItem(string docNumber);
}
