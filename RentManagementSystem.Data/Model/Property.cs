using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentManagementSystem.Data
{
    //=========================================>  Description: A property can have one or multiple flats and a flat can have a tenent who pays his/her rent and bills. A property can accrue expenses. May be you need billing for those expenses like pics of damage itme or property or maintenace such as paints or eletricity. Labour charges and material. Depriciation value every year. 2 Crore divided by 30 years. or 1,20,000,00  / 360 = 33,333 Rs every month.




    //=========================================>  Creating classes is more important becuase it will give you encouragement to just keeep growing your ideas in the form of classes then relationship then pushing database schema to database using entity framework.
    //=========================================>   In future there are two ideas need to be implemented. First one is to upload image of paid bills and second one is process CSV file for collecting rent.
    //=========================================>   While I was trying to learn quickly I came to a conclusion (common sense). You can't learn everything once. Practice and watching tutorials goes hand in hand. If you can absorb watch the whole tutorial first and then rewatch with coding practice and tutorials.

    //=====> **************     In one to many relationship we always keep list of items in main class such as a property can have multiple flats and a class can have multiple students and foreign key always go to List class such as Flat or sutdent.
    //=====> **************     In one to one relationship Foreign key could be done either way. We could do that by having a foreign key on classroom into the teacher, or a foreign key on the Teacher into the classroom. And it's completely balanced. There is no obvious way to infer that. So what we do have to do - well, a couple of ways we can do it. The way I would normally go is if I decided that it was going to be the Teacher that contained the forign Classroom key into the Classroom, then i would simply put that foreign key on there. So here we would have an 'int' because that's what my Ids are, and then I would simply follow the convention that would we talked about in the earlier videos, which is to use the property name plus id. So i've got a ClassroomId in there we can now see when we 
    public class Property//classroom
    {
        public int PropertyId { get; set; }
        public string PropertyAddress { get; set; }
        public string Description { get; set; }
        public ICollection<Flat> Flat { get; set; }
    }
}
