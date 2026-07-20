using ApniDukaan.Core.Entities;
using ApniDukaan.Core.RepositoryContracts;
using ApniDukaan.Core.RequestDTO;
using ApniDukaan.Core.ResponseDTO;
using ApniDukaan.Core.ServiceContracts;
using AutoMapper;

namespace ApniDukaan.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        { 
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
        {
            ApplicationUser applicationUser = new ApplicationUser()
            {
                Email = registerRequest.Email,
                Password = registerRequest.Password,
                PersonName = registerRequest.PersonName,
                Gender = Convert.ToString(registerRequest.Gender)
            };

            ApplicationUser? registeredUser = await _userRepository.AddUser(applicationUser);

            if (registeredUser == null)
                return null;

            //return new AuthenticationResponse
            //{
            //    UserID = registeredUser.UserId,
            //    Email = registeredUser.Email,
            //    PersonName = registeredUser.PersonName,
            //    Gender = registeredUser.Gender,
            //    IsAuthenticated = true,
            //    Token = "dummy-token" // In a real application, generate a JWT or similar token here
            //};
            var authenticationResponse = _mapper.Map<AuthenticationResponse>(registeredUser);
            authenticationResponse.IsAuthenticated = true;
            authenticationResponse.Token = "dummy-token"; // In a real application, generate a JWT or similar token here

            return authenticationResponse;
        }

        public async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
        {
            ApplicationUser? user = await _userRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);

            if (user == null)
                return null;

            //return new AuthenticationResponse
            //{
            //    UserID = user.UserId,
            //    Email = user.Email,
            //    PersonName = user.PersonName,
            //    Gender = user.Gender,
            //    IsAuthenticated = true,
            //    Token = "dummy-token" // In a real application, generate a JWT or similar token here
            //};
            var authenticationResponse = _mapper.Map<AuthenticationResponse>(user);
            authenticationResponse.IsAuthenticated = true;
            authenticationResponse.Token = "dummy-token"; // In a real application, generate a JWT or similar token here

            return authenticationResponse;
        }
    }
}