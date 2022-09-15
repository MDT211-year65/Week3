namespace Test_Grade_And_User;

public class GradeTest {

    int mockScore = 89;

    private Grade MockGradeData() {
        Grade grade = new Grade(mockScore);

        return grade;
    }

    [Fact]
    public void TestCreateGrade() {
        Assert.IsType<Grade>(MockGradeData());
    }

    [Fact]
    public void TestShowGrade() {
        Assert.Equal(MockGradeData().ShowGrade(), "Grade A");
    }

    [Fact]
    public void TestShowScore() {
        Assert.Equal(MockGradeData().ShowScore(), mockScore);
    }

    [Fact]
    public void TestIsGradeA() {
       int score = 85;

       Assert.True(MockGradeData().IsGradeA(score));
    }

    [Fact]
    public void TestIsGradeAIsInCorrect() {
        int score = 75;

        Assert.False(MockGradeData().IsGradeA(score));
    }

    [Fact]
    public void TestIsGradeBPlus() {
        int score = 75;

        Assert.True(MockGradeData().IsGradeBPlus(score));
    }

    [Fact]
    public void TestIsGradeBPlusIsInCorrect() {
        int score = 85;

        Assert.False(MockGradeData().IsGradeBPlus(score));
    }

    [Fact]
    public void TestIsGradeB() {
        int score = 70; 

        Assert.True(MockGradeData().IsGradeB(score));
    }

    [Fact]
    public void TestIsGradeBIsInCorrect() {
        int score = 79;

        Assert.False(MockGradeData().IsGradeB(score));
    }

    [Fact]
    public void TestIsGradeCPlus() {
        int score = 69;

        Assert.True(MockGradeData().IsGradeCPlus(score));
    }

    [Fact]
    public void TestIsGradeCPlusIsInCorrect() {
        int score = 60;

        Assert.False(MockGradeData().IsGradeCPlus(score));
    }

     [Fact]
    public void TestConvertScoreToGrade() {
        string grade = MockGradeData().ConvertScoreToGrade(mockScore);

        Assert.Equal(grade, "Grade A");
    }

    [Fact]
    public void TestIsGradeC() {
        int score = 60; 

        Assert.True(MockGradeData().IsGradeC(score));
    }

    [Fact]
    public void TestIsGradeCIsInCorrect() {
        int score = 55;

        Assert.False(MockGradeData().IsGradeC(score));
    }

    [Fact]
    public void TestIsGradeDPlus() {
        int score = 59;

        Assert.True(MockGradeData().IsGradeDPlus(score));
    }

    [Fact]
    public void TestIsGradeDPlusIsInCorrect() {
        int score = 50;

        Assert.False(MockGradeData().IsGradeDPlus(score));
    }

    [Fact]
    public void TestIsGradeD() {
        int score = 50;

        Assert.True(MockGradeData().IsGradeD(score));
    }

    [Fact]
    public void TestIsGradeDIsInCorrect() {
        int score = 49;

        Assert.False(MockGradeData().IsGradeD(score));
    }

    [Fact]
    public void TestIsGradeF() {
        int score = 49;
        
        Assert.True(MockGradeData().IsGradeF(score));
    }

    [Fact]
    public void TestIsGradeFIsInCorrect() {
        int score = 59;
        
        Assert.False(MockGradeData().IsGradeF(score));
    }

}