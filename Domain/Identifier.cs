namespace Motocycle_contest.Domain;

public interface Identifier<Tid>
{
   Tid GetId();
   void SetId(Tid id);
}
