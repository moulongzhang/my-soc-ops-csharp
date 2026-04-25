namespace SocOps.Data;

public static class Questions
{
    public const string FreeSpace = "FREE SPACE";

    public static readonly List<string> QuestionsList = new()
    {
        // Skill Bingo
        "can explain a technical concept simply",
        "has taught a teammate a new tool",
        "uses keyboard shortcuts daily",
        "has automated a repetitive task",
        "has written documentation this month",
        "can debug without panicking",
        "has learned a new skill recently",
        "has given a helpful code review",

        // Team Bingo
        "has paired with someone this week",
        "knows everyone's preferred meeting style",
        "has celebrated a teammate's win",
        "has unblocked someone recently",
        "has facilitated a team discussion",
        "has shared context before being asked",
        "has joined a cross-team project",
        "has asked a great clarifying question",

        // Work Culture Bingo
        "protects focus time on the calendar",
        "takes walking meetings",
        "has a favorite async update format",
        "starts meetings with clear outcomes",
        "has improved a team ritual",
        "keeps a tidy task board",
        "has advocated for work-life balance",
        "shares kudos generously"
    };
}
