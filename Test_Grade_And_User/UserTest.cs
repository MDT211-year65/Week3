namespace Test_Grade_And_User;

public class UserTest
{
    string mockName = "kittinun";
    string mockSurname = "chobtham";
    string mockStudentID = "52217504";
    int mockScore = 89;

    private User MockUserData() {
        User user = new User(mockName, mockSurname, mockStudentID, mockScore);

        return user;
    }

    [Fact]
    public void TestCreateUser() {
        Assert.IsType<User>(MockUserData());
    }

    [Fact]
    public void TestPrintScore() {
        Assert.Equal(mockScore, MockUserData().PrintScore());
    }

    [Fact]
    public void TestPrintGrade() {
        Assert.Equal(MockUserData().PrintGrade(), "Grade A");
    }

    [Fact]
    public void TestPrintUserInformation() {
        string mockUserInformation = "User information is : " 
        + MockUserData().name + " " + MockUserData().surname + " " +
         MockUserData().studentID + " Score is: " +
         MockUserData().PrintScore() + " Grade is:" +
         MockUserData().PrintGrade();

        Assert.Equal(MockUserData().PrintUserInformation(), mockUserInformation);
    }
}