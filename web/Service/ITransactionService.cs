//using web.Model;
using web.DatabaseModel;
using web.ViewModel;

namespace web.Service;

public interface ITransactionService {
    List<TransactionViewModel> GetAllTransactions();

    TransactionViewModel GetTransactionById(int id);
}