using System.Collections.Generic;
using System.Web.Http;

public class ItemsController : ApiController
{
    private static List<Item> items = new List<Item>();

    // GET api/items
    public IHttpActionResult Get()
    {
        return Ok(items);
    }

    // POST api/items
    public IHttpActionResult Post(Item item)
    {
        items.Add(item);
        return Ok();
    }

    // PUT api/items/5
    public IHttpActionResult Put(int id, Item item)
    {
        var existingItem = items.Find(i => i.Id == id);
        if (existingItem == null)
        {
            return NotFound();
        }

        existingItem.Name = item.Name;
        existingItem.Description = item.Description;

        return Ok();
    }

    // DELETE api/items/5
    public IHttpActionResult Delete(int id)
    {
        var itemToRemove = items.Find(i => i.Id == id);
        if (itemToRemove == null)
        {
            return NotFound();
        }

        items.Remove(itemToRemove);

        return Ok();
    }
}
