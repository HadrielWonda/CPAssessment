using CPAssessment.Models.ApplicationForm;

namespace CPAssessment.Service;

    public interface IApplicationFormService
    {
        Task<ApplicationForm> GetApplicationFormData(int Id);
        Task SaveApplicationForm(ApplicationForm applicationForm);
        Task DeleteApplicationForm(int Id);
    }

