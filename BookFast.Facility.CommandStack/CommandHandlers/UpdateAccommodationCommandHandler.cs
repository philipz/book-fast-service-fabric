using BookFast.Facility.CommandStack.Commands;
using BookFast.Facility.CommandStack.Repositories;
using BookFast.Facility.Domain.Exceptions;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BookFast.Facility.CommandStack.CommandHandlers
{
    public class UpdateAccommodationCommandHandler : IRequestHandler<UpdateAccommodationCommand>
    {
        private readonly IAccommodationRepository repository;
        private readonly IMediator mediator;

        public UpdateAccommodationCommandHandler(IAccommodationRepository repository, IMediator mediator)
        {
            this.repository = repository;
            this.mediator = mediator;
        }

        public async Task Handle(UpdateAccommodationCommand message, CancellationToken cancellationToken)
        {
            var accommodation = await repository.FindAsync(message.AccommodationId);
            if (accommodation == null)
            {
                throw new AccommodationNotFoundException(message.AccommodationId);
            }

            accommodation.Update(
                message.Name,
                message.Description,
                message.RoomCount,
                message.Images);

            await repository.UpdateAsync(accommodation);
            await repository.SaveChangesAsync();

            await accommodation.RaiseEventsAsync(mediator);
        }
    }
}
