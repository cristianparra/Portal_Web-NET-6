namespace PortalWeb.Domain
{
    /// <summary>
    /// Class Implementation Response Return Methods, Controller, Etc
    /// </summary>
    public class ExampleResponse
    {
        public Response<bool> GetResponse_Var(long Id)
        {
            Response<bool> response = new Response<bool>()
            {
                Result = false
            };

            try
            {
                response.Result = true;
            }
            catch (Exception ex)
            {
                string message = "ExampleResponse.GetResponse_Var " + ex.Message;
                if (ex.InnerException != null)
                    message += ", detail: " + ex.InnerException.Message;

                response.Code = "500";
                response.Message = message;
            }

            return response;
        }

        public Response<Item> GetResponse_Obj(long Id)
        {
            Response<Item> response = new Response<Item>()
            {
                Result = new Item()
            };

            try
            {
                response.Result = new Item()
                {
                    Name = "1_Name",
                    Id = 1
                };
            }
            catch (Exception ex)
            {
                string message = "ExampleResponse.GetResponse_Obj " + ex.Message;
                if (ex.InnerException != null)
                    message += ", detail: " + ex.InnerException.Message;

                response.Code = "500";
                response.Message = message;
            }

            return response;
        }

        public Response<List<Item>> GetResponse_List(long Id)
        {
            Response<List<Item>> response = new Response<List<Item>>()
            {
                Result = new List<Item>()
            };

            try
            {
                response.Result = new List<Item>() {
                    new Item() {
                        Name = "1_Name",
                        Id = 1
                    }
                };
            }
            catch (Exception ex)
            {
                string message = "ExampleResponse.GetResponse_List " + ex.Message;
                if (ex.InnerException != null)
                    message += ", detail: " + ex.InnerException.Message;

                response.Code = "500";
                response.Message = message;
            }

            return response;
        }
    }

    /// <summary>
    /// Class Example
    /// </summary>
    public class Item {
        public string Name { get; set; }
        public long Id { get; set; }
    }
}