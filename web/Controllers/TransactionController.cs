using web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using web.Service;
using System.Diagnostics;

namespace web.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController : ControllerBase, ITransactionService {
    private readonly ITransactionService transactionService;

    public TransactionController(ITransactionService transactionService)
    {
        this.transactionService = transactionService;
    }

    [Route("GetAllTransactions")]
    [HttpGet]
    public List<TransactionViewModel> GetAllTransactions()
    {
        return transactionService.GetAllTransactions();
    }

    [Route("GetTransaction/{id}")]
    [HttpGet]
    public TransactionViewModel GetTransactionById(int id)
    {
        return transactionService.GetTransactionById(id);
    }
}
