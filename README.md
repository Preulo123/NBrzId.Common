# Brazilian Identifiers Common Library

This library provides basic types for handling Brazilian identifiers, such as CPF and CNPJ, in .NET applications.

## Table of Contents
- [Overview](#overview)
- [Getting Started](#getting-started)
- [Installation](#installation)
- [Usage](#usage)
- [Compatibility](#compatibility)
- [Roadmap](#roadmap)
- [Contributing](#contributing)
- [License](#license)

## Overview

This library introduces types specifically designed to handle Brazilian identifiers with ease and reliability in .NET applications. The initial release, `v0.1.0`, includes the following core components:
- **`IBrzIdentifier`**: A base interface for identifiers.
- **`Cpf`**: Class to represent CPF identifiers.
- **`Cnpj`**: Class to represent CNPJ identifiers.
- **`BrzIdentifier`**: A static access point providing singleton instances of `Cpf` and `Cnpj`.
- **`BaseBrzIdentifier`**: An abstract class with a default implementation for the property `FormattingCharacters`.

Release `v1.0.0` included changes to support the new alphanumeric CNPJ format according to "Instrução Normativa RFB nº 2229".

## Getting Started

### Installation

To include this library in your .NET project, add it as a dependency via NuGet:

```sh
dotnet add package NBrzId.Common --version 1.0.1
```

## Usage

You can start by accessing the pre-build identifier instances directly through the BrzIdentifier static class. Below is an example that demonstrates basic functionality:

```csharp
using YourLibraryNamespace;

var cpf = BrzIdentifier.Cpf;

Console.WriteLine(cpf.Mask);
```

You may also create your own identifier classes for any identifier by implementing the `IBrzIdentifier` interface:

```csharp
using YourLibraryNamespace;

public class VoterID : IBrzIdentifier
{
    public char[] FormattingCharacters => new char[] { '/' };

    public int    Length           => 12;

    public string Mask             => "NNNNNNNNNN/NN";

    public char   PaddingCharacter => '0';
}
```

## Compatibility

This library targets .NET Standard 2.0, ensuring compatibility with .NET Core, .NET 5/6/7/8, and .NET Framework 4.6.1+.

## Roadmap

This library is in active development. Planned features for future releases include additional Brazilian identifiers (IE, Suframa, PIS) as needed.

## Contributing

Contributions are welcome! Please open an issue to report bugs or discuss improvements.

## License

This project is licensed under the MIT License. See the LICENSE.md file for details.
