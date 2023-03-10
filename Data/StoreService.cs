namespace card_storm.Data;

public class StoreService
{


  public List<Item> SelectedItems { get; set; } = new();

  public void AddItemToCart(Guid itemId)
  {
    var item = storeItems.First(p => p.id == itemId);
    if (SelectedItems.Contains(item) is false)
    {
      SelectedItems.Add(item);
    }
  }


  // Create our List of items
  public List<Item> storeItems = new List<Item>{
    new Item { id =  Guid.NewGuid() , title="Arlo Go 2 4G/Wi-Fi Security Camera", description="Arlo’s most flexible full HD camera gives you intelligent security at more locations than ever. Arlo Go 2 delivers 100% wire-free security with 4G or Wi-Fi connectivity. ", price= 650, img_Url="./Assets/Cams/cam1.jpeg" },

    new Item{id= Guid.NewGuid() , title="Arlo Pro 4 - 2K Wire-Free Spotlight 4 Camera Kit", description="Rest easy knowing your home is protected, whether you’re there or away with Arlo Pro 4. With no wires, your camera connects directly to your Wi-Fi network so you can easily install it in minutes.", price= 978, img_Url="./Assets/Cams/cam2.jpeg" },

    new Item{id= Guid.NewGuid() , title="Swann 4K Thermal Sensing Spotlight DVR Camera", description="See faces, license plates, packages & more with crystal clear 4K resolution, that’s 4x clearer than 1080p with powerful digital zoom – ensuring you won’t miss a thing.", price= 250, img_Url="./Assets/Cams/cam3.jpeg" },

    new Item{id= Guid.NewGuid() , title="Swann 4K Pan-Tilt Add On Camera",description="The SWNHD-900PT 4K Pan & Tilt NVR Security Camera is at the pinnacle of feature-packed crime-deterring security devices. With bright spotlights, red & blue flashing lights, two-way audio, and loud siren.", price=379, img_Url="./Assets/Cams/cam4.jpeg"},

    new Item{id= Guid.NewGuid() , title="Swann 4 Camera 1080P WiFi NVR Security System 1TB HDD", description="4 x 1080P HD Cameras with Controllable Spotlights & Sirens plus SwannNet™ Wi-Fi Connection.1080P HD Cameras provide crystal clear video & close-ups",price=695,img_Url="./Assets/Cams/cam5.jpeg"},

    new Item{id= Guid.NewGuid() , title="Orion Grid Connect 2MP Smart Outdoor Security Camera", description="This Orion SMART Outdoor Security Camera allows you to see", price=79,img_Url="./Assets/Cams/cam6.jpeg"},

    new Item{id= Guid.NewGuid() , title="Swann Dome Imitation Camera With Flashing Light", description="The Swann Dome Imitation Camera looks real with it red flashing light. Discourage thieves and protect property with visible deterrent. Quick and easy to install",price=16, img_Url="./Assets/Cams/cam7.jpeg"},

    new Item{id= Guid.NewGuid() , title="Orion Grid Connect Smart HD 3MP Security Camera And Twin Floodlight", description="This Orion SMART Twin Floodlight Camera allows you to see", price=149, img_Url="./Assets/Cams/cam8.jpeg"}
  };
}
