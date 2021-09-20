namespace RUFR.Api.Model
{
    /// <summary>
    /// типы событий
    /// </summary>
    public enum TypeEven : int
    {
        coming = 1,
        past = 2,
    }

    /// <summary>
    /// стадия проекта
    /// </summary>
    public enum ProjectStage : int
    {
        planned = 1,
        coming = 2,
        completed = 3,
    }

    /// <summary>
    /// вид проекта
    /// </summary>
    public enum TypeOfProject : int
    {
        scientificProjects = 1,
        educationalProjects = 2,
        scientificGrants = 3,
        educationalGrants = 4
    }

    /// <summary>
    /// тип истории
    /// </summary>
    public enum TypesOfHistory : int
    {
        projectStories = 1,
        studentStories = 2,
        salonParticipantsStories = 3,
        InteruniversityPartnership = 4
    }

}
