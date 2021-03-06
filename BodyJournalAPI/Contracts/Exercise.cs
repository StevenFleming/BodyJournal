using BodyJournalAPI.Entities;
using System.Linq;
using System.Collections.Generic;

namespace BodyJournalAPI.Contracts
{
  public interface IExerciseRepository : IRepositoryBase<Exercise>
  {
    Exercise GetExercise(int id);
    IEnumerable<Exercise> GetExercises();
    void CreateExercise(Exercise model);
    void UpdateExercise(int id, Exercise model);
    void DeleteExercise(int id);
  }
}