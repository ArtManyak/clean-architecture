namespace CleanArchitecture.CommonFiles;

// todo add DateTime CreationTime
public record Token(
#pragma warning restore SA1600
    string Value,
    DateTime ExpirationDateTime);