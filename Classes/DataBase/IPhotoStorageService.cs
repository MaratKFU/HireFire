using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.EntityFrameworkCore.Design;
using BCrypt.Net;
using Microsoft.Extensions.Configuration.Json;
using HireFire.Classes.Entities;

namespace HireFire.Classes.DataBase;
public interface IPhotoStorageService
{
    Task<string> UploadPhotoAsync(int userId, Stream photoStream, string fileName);
    Task DeletePhoto(string photoUrl);
    Task<Stream> DownloadPhotoAsync(string photoUrl);
}