using api_sample.DataTransferObjects;
using api_sample.Interfaces;

namespace api_sample.Services;

public abstract class SalesOrderService : ISalesOrderServices
{
    public void CreateItem(SalesOrderForCreateDto salesOrderForCreate)
    {
        throw new NotImplementedException();
    }

    public void UpdateItem(string docNumber, SalesOrderForUpdateDto salesOrderForUpdate)
    {
        throw new NotImplementedException();
    }

    public void DeleteItem(string docNumber)
    {
        throw new NotImplementedException();
    }

    public void GetItem(string docNumber)
    {
        throw new NotImplementedException();
    }
}