using CPAssessment.Models.ApplicationForm;

namespace CPAssessment.Database;

    public interface IApplicationFormDatabase
    {
        Task<ApplicationForm> GetApplicationFormData(int Id);
        Task SaveApplicationForm(ApplicationForm applicationForm);
        Task DeleteApplicationForm(int Id);
    }

