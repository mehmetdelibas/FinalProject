using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFreamwork;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }
        public IResult Add(Employee employee)
        {
            // iş kodları


            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.Add(employee);
            return new SuccessResult(Messages.EmployeeAdded);
        }

        public IDataResult<List<Employee>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
                return new ErrorDataResult<List<Employee>>(Messages.MaintenanceTime);

            //iş kodları, Yetki kontorlü
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetAll(), Messages.EmployeeListed);
        }

        public IDataResult<Employee> GetById(int employeeId)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(p => p.EmployeeId == employeeId));
        }
    }
}
