//Codigo ainda precisa ser reintegrado no projeto. Aqui contem apenas a logica que sera aplicada e destribuida no resto do projeto.

// valores que representam o nome do aluno e os detalhes da diciplina
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

//Metodo de calculo de horas totais.
int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

//Metodo de calculo de Pontos de Grade.
int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

//Conversos de resultado. 
decimal gradePointAvarage = (decimal) totalGradePoints/totalCreditHours;
int leadingDigit = (int) gradePointAvarage;
int trailingDigits = (int) (gradePointAvarage * 100) - (leadingDigit * 100);

Console.WriteLine($"Student: {studentName}\n");

Console.WriteLine("Course\t\t\t\tGrade\tCredit hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"Final GPA:\t\t\t{leadingDigit}.{trailingDigits}");