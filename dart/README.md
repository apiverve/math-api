# Math Calculator API - Dart/Flutter Client

Math Calculator performs mathematical operations including arithmetic, number properties, base conversions, and expression evaluation.

[![pub package](https://img.shields.io/pub/v/apiverve_math.svg)](https://pub.dev/packages/apiverve_math)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This is the Dart/Flutter client for the [Math Calculator API](https://apiverve.com/marketplace/math?utm_source=dart&utm_medium=referral&utm_content=readme).

## Installation

Add this to your `pubspec.yaml`:

```yaml
dependencies:
  apiverve_math: ^1.2.5
```

Then run:

```bash
dart pub get
# or for Flutter
flutter pub get
```

## Usage

```dart
import 'package:apiverve_math/apiverve_math.dart';

void main() async {
  final client = MathClient('YOUR_API_KEY');

  try {
    final response = await client.execute({
      'operation': 'add',
      'a': 10,
      'b': 5
    });

    print('Status: ${response.status}');
    print('Data: ${response.data}');
  } catch (e) {
    print('Error: $e');
  }
}
```

## Response

```json
{
  "status": "ok",
  "error": null,
  "data": {
    "result": 15,
    "operation": "add",
    "input": {
      "a": 10,
      "b": 5
    },
    "steps": [
      "10 + 5 = 15"
    ]
  }
}
```

## API Reference

- **API Home:** [Math Calculator API](https://apiverve.com/marketplace/math?utm_source=dart&utm_medium=referral&utm_content=readme)
- **Documentation:** [docs.apiverve.com/ref/math](https://docs.apiverve.com/ref/math?utm_source=dart&utm_medium=referral&utm_content=readme)

## Authentication

All requests require an API key. Get yours at [apiverve.com](https://apiverve.com?utm_source=dart&utm_medium=referral&utm_content=readme).

## License

MIT License - see [LICENSE](LICENSE) for details.

---

Built with Dart for [APIVerve](https://apiverve.com?utm_source=dart&utm_medium=referral&utm_content=readme)
