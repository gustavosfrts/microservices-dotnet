using RestauranteService.Dtos;

namespace RestauranteService.RabbitMqClient
{
    public interface IRabbitMqClient
    {
        public void PublicaRestaurante(RestauranteReadDto restauranteReadDto);
    }
}