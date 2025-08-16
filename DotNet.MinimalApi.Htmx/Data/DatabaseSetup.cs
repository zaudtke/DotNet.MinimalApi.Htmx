namespace DotNet.MinimalApi.Htmx.Data;

public static class DatabaseSetup
{
    public static ValueTask EnsureDatabase(IServiceProvider serviceProvider)
    {
        var dbContext = serviceProvider.CreateAsyncScope().ServiceProvider.GetRequiredService<LiteDbContext>();
        var contactsCollection = dbContext.Database.GetCollection<Contact>("Contacts");

        if (contactsCollection.Count() == 0)
        {
            contactsCollection.Insert(new Contact { Id = 1, Name = "Alice Johnson", Email = "alice.johnson@example.com" });
            contactsCollection.Insert(new Contact { Id = 2, Name = "Bob Smith", Email = "bob.smith@example.com" });
            contactsCollection.Insert(new Contact { Id = 3, Name = "Carol Williams", Email = "carol.williams@example.com" });
            contactsCollection.Insert(new Contact { Id = 4, Name = "David Brown", Email = "david.brown@example.com" });
            contactsCollection.Insert(new Contact { Id = 5, Name = "Eve Davis", Email = "eve.davis@example.com" });
            contactsCollection.Insert(new Contact { Id = 6, Name = "Frank Miller", Email = "frank.miller@example.com" });
            contactsCollection.Insert(new Contact { Id = 7, Name = "Grace Wilson", Email = "grace.wilson@example.com" });
            contactsCollection.Insert(new Contact { Id = 8, Name = "Henry Moore", Email = "henry.moore@example.com" });
            contactsCollection.Insert(new Contact { Id = 9, Name = "Ivy Taylor", Email = "ivy.taylor@example.com" });
            contactsCollection.Insert(new Contact { Id = 10, Name = "Jack Anderson", Email = "jack.anderson@example.com" });
            contactsCollection.Insert(new Contact { Id = 11, Name = "Kathy Thomas", Email = "kathy.thomas@example.com" });
            contactsCollection.Insert(new Contact { Id = 12, Name = "Leo Jackson", Email = "leo.jackson@example.com" });
            contactsCollection.Insert(new Contact { Id = 13, Name = "Mona White", Email = "mona.white@example.com" });
            contactsCollection.Insert(new Contact { Id = 14, Name = "Nate Harris", Email = "nate.harris@example.com" });
            contactsCollection.Insert(new Contact { Id = 15, Name = "Olivia Martin", Email = "olivia.martin@example.com" });
            contactsCollection.Insert(new Contact { Id = 16, Name = "Paul Thompson", Email = "paul.thompson@example.com" });
            contactsCollection.Insert(new Contact { Id = 17, Name = "Quinn Garcia", Email = "quinn.garcia@example.com" });
            contactsCollection.Insert(new Contact { Id = 18, Name = "Rita Martinez", Email = "rita.martinez@example.com" });
            contactsCollection.Insert(new Contact { Id = 19, Name = "Sam Robinson", Email = "sam.robinson@example.com" });
            contactsCollection.Insert(new Contact { Id = 20, Name = "Tina Clark", Email = "tina.clark@example.com" });
            contactsCollection.Insert(new Contact { Id = 21, Name = "Uma Rodriguez", Email = "uma.rodriguez@example.com" });
            contactsCollection.Insert(new Contact { Id = 22, Name = "Vince Lewis", Email = "vince.lewis@example.com" });
            contactsCollection.Insert(new Contact { Id = 23, Name = "Wendy Lee", Email = "wendy.lee@example.com" });
            contactsCollection.Insert(new Contact { Id = 24, Name = "Xander Walker", Email = "xander.walker@example.com" });
            contactsCollection.Insert(new Contact { Id = 25, Name = "Yara Hall", Email = "yara.hall@example.com" });
            contactsCollection.Insert(new Contact { Id = 26, Name = "Zane Allen", Email = "zane.allen@example.com" });
            contactsCollection.Insert(new Contact { Id = 27, Name = "Amber Young", Email = "amber.young@example.com" });
            contactsCollection.Insert(new Contact { Id = 28, Name = "Blake King", Email = "blake.king@example.com" });
            contactsCollection.Insert(new Contact { Id = 29, Name = "Cindy Wright", Email = "cindy.wright@example.com" });
            contactsCollection.Insert(new Contact { Id = 30, Name = "Derek Scott", Email = "derek.scott@example.com" });
            contactsCollection.Insert(new Contact { Id = 31, Name = "Ella Green", Email = "ella.green@example.com" });
            contactsCollection.Insert(new Contact { Id = 32, Name = "Finn Adams", Email = "finn.adams@example.com" });
            contactsCollection.Insert(new Contact { Id = 33, Name = "Gina Baker", Email = "gina.baker@example.com" });
            contactsCollection.Insert(new Contact { Id = 34, Name = "Hank Nelson", Email = "hank.nelson@example.com" });
            contactsCollection.Insert(new Contact { Id = 35, Name = "Iris Carter", Email = "iris.carter@example.com" });
            contactsCollection.Insert(new Contact { Id = 36, Name = "Jake Perez", Email = "jake.perez@example.com" });
            contactsCollection.Insert(new Contact { Id = 37, Name = "Kara Roberts", Email = "kara.roberts@example.com" });
            contactsCollection.Insert(new Contact { Id = 38, Name = "Liam Evans", Email = "liam.evans@example.com" });
            contactsCollection.Insert(new Contact { Id = 39, Name = "Mia Turner", Email = "mia.turner@example.com" });
            contactsCollection.Insert(new Contact { Id = 40, Name = "Noah Phillips", Email = "noah.phillips@example.com" });
            contactsCollection.Insert(new Contact { Id = 41, Name = "Owen Campbell", Email = "owen.campbell@example.com" });
            contactsCollection.Insert(new Contact { Id = 42, Name = "Penny Parker", Email = "penny.parker@example.com" });
            contactsCollection.Insert(new Contact { Id = 43, Name = "Quincy Edwards", Email = "quincy.edwards@example.com" });
            contactsCollection.Insert(new Contact { Id = 44, Name = "Ruby Collins", Email = "ruby.collins@example.com" });
            contactsCollection.Insert(new Contact { Id = 45, Name = "Sean Stewart", Email = "sean.stewart@example.com" });
            contactsCollection.Insert(new Contact { Id = 46, Name = "Tara Sanchez", Email = "tara.sanchez@example.com" });
            contactsCollection.Insert(new Contact { Id = 47, Name = "Ulysses Morris", Email = "ulysses.morris@example.com" });
            contactsCollection.Insert(new Contact { Id = 48, Name = "Vera Rogers", Email = "vera.rogers@example.com" });
            contactsCollection.Insert(new Contact { Id = 49, Name = "Will Reed", Email = "will.reed@example.com" });
            contactsCollection.Insert(new Contact { Id = 50, Name = "Xenia Cook", Email = "xenia.cook@example.com" });
            contactsCollection.Insert(new Contact { Id = 51, Name = "Yusuf Morgan", Email = "yusuf.morgan@example.com" });
            contactsCollection.Insert(new Contact { Id = 52, Name = "Zoey Bell", Email = "zoey.bell@example.com" });
            contactsCollection.Insert(new Contact { Id = 53, Name = "Aiden Murphy", Email = "aiden.murphy@example.com" });
            contactsCollection.Insert(new Contact { Id = 54, Name = "Brooke Bailey", Email = "brooke.bailey@example.com" });
            contactsCollection.Insert(new Contact { Id = 55, Name = "Chase Rivera", Email = "chase.rivera@example.com" });
            contactsCollection.Insert(new Contact { Id = 56, Name = "Daisy Cooper", Email = "daisy.cooper@example.com" });
            contactsCollection.Insert(new Contact { Id = 57, Name = "Ethan Richardson", Email = "ethan.richardson@example.com" });
            contactsCollection.Insert(new Contact { Id = 58, Name = "Faith Cox", Email = "faith.cox@example.com" });
            contactsCollection.Insert(new Contact { Id = 59, Name = "Gavin Howard", Email = "gavin.howard@example.com" });
            contactsCollection.Insert(new Contact { Id = 60, Name = "Hailey Ward", Email = "hailey.ward@example.com" });
            contactsCollection.Insert(new Contact { Id = 61, Name = "Isaac Torres", Email = "isaac.torres@example.com" });
            contactsCollection.Insert(new Contact { Id = 62, Name = "Jenna Peterson", Email = "jenna.peterson@example.com" });
            contactsCollection.Insert(new Contact { Id = 63, Name = "Kyle Gray", Email = "kyle.gray@example.com" });
            contactsCollection.Insert(new Contact { Id = 64, Name = "Lily Ramirez", Email = "lily.ramirez@example.com" });
            contactsCollection.Insert(new Contact { Id = 65, Name = "Mason James", Email = "mason.james@example.com" });
            contactsCollection.Insert(new Contact { Id = 66, Name = "Nina Watson", Email = "nina.watson@example.com" });
            contactsCollection.Insert(new Contact { Id = 67, Name = "Omar Brooks", Email = "omar.brooks@example.com" });
            contactsCollection.Insert(new Contact { Id = 68, Name = "Paige Kelly", Email = "paige.kelly@example.com" });
            contactsCollection.Insert(new Contact { Id = 69, Name = "Ryan Sanders", Email = "ryan.sanders@example.com" });
            contactsCollection.Insert(new Contact { Id = 70, Name = "Sara Price", Email = "sara.price@example.com" });
            contactsCollection.Insert(new Contact { Id = 71, Name = "Tyler Bennett", Email = "tyler.bennett@example.com" });
            contactsCollection.Insert(new Contact { Id = 72, Name = "Ursula Wood", Email = "ursula.wood@example.com" });
            contactsCollection.Insert(new Contact { Id = 73, Name = "Victor Barnes", Email = "victor.barnes@example.com" });
            contactsCollection.Insert(new Contact { Id = 74, Name = "Willa Ross", Email = "willa.ross@example.com" });
            contactsCollection.Insert(new Contact { Id = 75, Name = "Ximena Henderson", Email = "ximena.henderson@example.com" });
            contactsCollection.Insert(new Contact { Id = 76, Name = "Yosef Coleman", Email = "yosef.coleman@example.com" });
            contactsCollection.Insert(new Contact { Id = 77, Name = "Zara Jenkins", Email = "zara.jenkins@example.com" });
            contactsCollection.Insert(new Contact { Id = 78, Name = "Alec Perry", Email = "alec.perry@example.com" });
            contactsCollection.Insert(new Contact { Id = 79, Name = "Bethany Powell", Email = "bethany.powell@example.com" });
            contactsCollection.Insert(new Contact { Id = 80, Name = "Cameron Long", Email = "cameron.long@example.com" });
            contactsCollection.Insert(new Contact { Id = 81, Name = "Dylan Patterson", Email = "dylan.patterson@example.com" });
            contactsCollection.Insert(new Contact { Id = 82, Name = "Elena Hughes", Email = "elena.hughes@example.com" });
            contactsCollection.Insert(new Contact { Id = 83, Name = "Felix Flores", Email = "felix.flores@example.com" });
            contactsCollection.Insert(new Contact { Id = 84, Name = "Georgia Simmons", Email = "georgia.simmons@example.com" });
            contactsCollection.Insert(new Contact { Id = 85, Name = "Hudson Foster", Email = "hudson.foster@example.com" });
            contactsCollection.Insert(new Contact { Id = 86, Name = "Isabel Butler", Email = "isabel.butler@example.com" });
            contactsCollection.Insert(new Contact { Id = 87, Name = "Jonah Bryant", Email = "jonah.bryant@example.com" });
            contactsCollection.Insert(new Contact { Id = 88, Name = "Kelsey Alexander", Email = "kelsey.alexander@example.com" });
            contactsCollection.Insert(new Contact { Id = 89, Name = "Logan Russell", Email = "logan.russell@example.com" });
            contactsCollection.Insert(new Contact { Id = 90, Name = "Megan Griffin", Email = "megan.griffin@example.com" });
            contactsCollection.Insert(new Contact { Id = 91, Name = "Nathaniel Diaz", Email = "nathaniel.diaz@example.com" });
            contactsCollection.Insert(new Contact { Id = 92, Name = "Olga Hayes", Email = "olga.hayes@example.com" });
            contactsCollection.Insert(new Contact { Id = 93, Name = "Preston Myers", Email = "preston.myers@example.com" });
            contactsCollection.Insert(new Contact { Id = 94, Name = "Quiana Ford", Email = "quiana.ford@example.com" });
            contactsCollection.Insert(new Contact { Id = 95, Name = "Riley Graham", Email = "riley.graham@example.com" });
            contactsCollection.Insert(new Contact { Id = 96, Name = "Sophie Stone", Email = "sophie.stone@example.com" });
            contactsCollection.Insert(new Contact { Id = 97, Name = "Tristan Warren", Email = "tristan.warren@example.com" });
            contactsCollection.Insert(new Contact { Id = 98, Name = "Umar Chapman", Email = "umar.chapman@example.com" });
            contactsCollection.Insert(new Contact { Id = 99, Name = "Violet Black", Email = "violet.black@example.com" });
            contactsCollection.Insert(new Contact { Id = 100, Name = "Wyatt Stephens", Email = "wyatt.stephens@example.com" });
        }
        contactsCollection.EnsureIndex("Name");

        return ValueTask.CompletedTask;
    }
}