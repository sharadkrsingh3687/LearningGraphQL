using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Contract.Services
{
    public interface IHumanResourcesService
    {
        Task<IEnumerable<DepartmentResponse>> GetDepartmentListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<EmployeeResponse>> GetEmployeeListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<EmployeeDepartmentHistoryResponse>> GetEmployeeDepartmentHistoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<EmployeePayHistoryResponse>> GetEmployeePayHistoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<JobCandidateResponse>> GetJobCandidateListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ShiftResponse>> GetShiftListAsync(CancellationToken cancellationToken);
    }

    
}
