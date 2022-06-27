using AutoMapper;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Entities;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Persist.Contract;

namespace LearningGraphQL.Business.Services
{
    public class HumanResourcesService : IHumanResourcesService
    {
        private readonly IMapper _mapper;
        private readonly IAdventureWorksDataProvider _dataProvider;
        public HumanResourcesService(IMapper mapper, IAdventureWorksDataProvider provider)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._dataProvider = provider;
        }
        public async Task<IEnumerable<ShiftResponse>> GetShiftListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetShiftsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Shift>, IEnumerable<ShiftResponse>>(resultSet);
        }
        public async Task<IEnumerable<DepartmentResponse>> GetDepartmentListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetDepartmentsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentResponse>>(resultSet);
        }
        public async Task<IEnumerable<JobCandidateResponse>> GetJobCandidateListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetJobCandidatesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<JobCandidate>, IEnumerable<JobCandidateResponse>>(resultSet);
        }
        public async Task<IEnumerable<EmployeeDepartmentHistoryResponse>> GetEmployeeDepartmentHistoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetEmployeeDepartmentHistoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<EmployeeDepartmentHistory>, IEnumerable<EmployeeDepartmentHistoryResponse>>(resultSet);
        }
        public async Task<IEnumerable<EmployeeResponse>> GetEmployeeListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetEmployeesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeResponse>>(resultSet);
        }
        public async Task<IEnumerable<EmployeePayHistoryResponse>> GetEmployeePayHistoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetEmployeePayHistoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<EmployeePayHistory>, IEnumerable<EmployeePayHistoryResponse>>(resultSet);
        }

    }
}
