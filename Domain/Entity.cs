namespace Motocycle_contest.Domain;

public class Entity
{
   protected int id;

   public Entity(int id)
   {
      this.id = id;
   }

   public int getId()
   {
      return this.id;
   }
}