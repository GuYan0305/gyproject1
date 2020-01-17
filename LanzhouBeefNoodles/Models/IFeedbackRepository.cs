using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanzhouBeefNoodles.Models;

namespace LanzhouBeefNoodles.Models
{
    public interface IFeedbackRepository//27->MockFeedbackRepository
    {
        IEnumerable<Feedback> GetAllFeedbacks();
        void AddFeedback(Feedback feedback);//37->MockFeedbackRepository.cs实现
    }
}
