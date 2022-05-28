using (ApplicationContext db = new ApplicationContext())
{
    db.Users.Add(new User
    {
        PassportSeria = "1234",
        PassportNumber = "345678",
        Name = "Tom"
    });
    db.Users.Add(new User
    {
        PassportSeria = "1414",
        PassportNumber = "45477",
        Name = "Bob"
    });
    db.Users.Add(new User
    {
        PassportSeria = "00014",
        PassportNumber = "45445",
        Name = "Kate"
    });
    db.Users.Add(new User
    {
        PassportSeria = "4410",
        PassportNumber = "14054",
        Name = "Maks"
    });
    db.Users.Add(new User
    {
        PassportSeria = "7788",
        PassportNumber = "45444",
        Name = "Alice"
    });
    db.Users.Add(new User
    {
        PassportSeria = "3333",
        PassportNumber = "44447",
        Name = "Jane"
    });
    db.Users.Add(new User
    {
        PassportSeria = "0121",
        PassportNumber = "24223",
        Name = "Serge"
    });
    db.Users.Add(new User
    {
        PassportSeria = "1245",
        PassportNumber = "78954",
        Name = "Eity"
    });
    db.Users.Add(new User
    {
        PassportSeria = "1010",
        PassportNumber = "45872",
        Name = "Nanny"
    });
    db.Users.Add(new User
    {
        PassportSeria = "1111",
        PassportNumber = "00000",
        Name = "Taty"
    });
    db.SaveChanges();
    var users = db.Users.ToList();
    foreach (var u in users)
        Console.WriteLine($"{u.Name} : {u.PassportSeria} {u.PassportNumber}");
}
