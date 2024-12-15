//using web.Model;
using web.DatabaseModel;
using web.ViewModel;

namespace web.Repository;

public interface ITransactionRepository {
    List<Transaction> GetAllTransactions();

    Transaction GetTransactionById(int id);
}