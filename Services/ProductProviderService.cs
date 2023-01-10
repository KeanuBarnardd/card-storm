
namespace card_storm.Services;

public static class ProductProviderService
{



  public static re List<Product> Products = new List<Product>{

    new Product  { Id  =  Guid.NewGuid(), Name="Arlo Go 2 4G/Wi-Fi SecuritCamera", Description ="Arlo’s most flexible full HD camera gives yointelligent security at more locations than ever. Arlo Go 2 delivers 100wire-free security with 4G or Wi-Fi connectivity. ", Price= 650, img_Url="Assets/Cams/cam1.jpeg" },

    new Product {Id = Guid.NewGuid(), Name="Arlo Pro 4 - 2K Wire-Free Spotlight 4 Camera Kit", Description ="Rest easy knowing your home is protected, whether you’re there or away with Arlo Pro 4. With no wires, your camera connects directly to your Wi-Fi network so you can.", Price= 978, img_Url="./Assets/Cams/cam2.jpeg" },

    new Product {Id = Guid.NewGuid(), Name="Swann 4K Thermal Sensing Spotlight DVR Camera", Description ="See faces, license plates, packages & more with crystal clear 4K resolution, that’s 4x clearer than 1080p with powerful digital zoom – ensuring you won’t miss a thing.", Price= 250, img_Url="./Assets/Cams/cam3.jpeg" },

    new Product {Id = Guid.NewGuid(), Name="Swann 4K Pan-Tilt Add On Camera",Description ="The SWNHD-900PT 4K Pan & Tilt NVR Security Camera is at the pinnacle of feature-packed crime-deterring security devices. With bright spotlights, red & blue flashing lights, two-way audio, and loud siren, you can intimidate intruders.", Price=379, img_Url="./Assets/Cams/cam4.jpeg"},

    new Product {Id = Guid.NewGuid(), Name="Swann 4 Camera 1080P WiFi NVR Security System 1TB HDD", Description ="4 x 1080P HD Cameras with Controllable Spotlights & Sirens plus SwannNet™ Wi-Fi Connection.1080P HD Cameras provide crystal clear video & close-ups.",Price=695,img_Url="./Assets/Cams/cam5.jpeg"},

    new Product {Id = Guid.NewGuid(), Name="Orion Grid Connect 2MP Smart Outdoor Security Camera", Description ="This Orion SMART Outdoor Security Camera allows you to see and record activity in front of the home/garage from your smartphone or tablet anywhere and anytime.", Price=79,img_Url="./Assets/Cams/cam6.jpeg"},

    new Product {Id = Guid.NewGuid(), Name="Swann Dome Imitation Camera With Flashing Light", Description ="The Swann Dome Imitation Camera looks real with it red flashing light. Discourage thieves and protect property with visible deterrent. Quick and easy to install with no cable mess.",Price=16, img_Url="./Assets/Cams/cam7.jpeg"},

    new Product {Id = Guid.NewGuid(), Name="Orion Grid Connect Smart HD 3MP Security Camera.", Description ="This Orion SMART Twin Floodlight Camera allows you to see and record activity in front of the home/garage from your smartphone or tablet anywhere and anytime.", Price=149, img_Url="./Assets/Cams/cam8.jpeg"}
  };
}