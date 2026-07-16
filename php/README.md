# Math Calculator API - PHP Package

Math Calculator performs mathematical operations including arithmetic, number properties, base conversions, and expression evaluation.

## Installation

Install via Composer:

```bash
composer require apiverve/math
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```php
<?php

require_once 'vendor/autoload.php';

use APIVerve\Math\Client;

// Initialize the client
$client = new Client('YOUR_API_KEY');

// Make a request
$response = $client->execute([
    'operation' => 'add',
    'a' => 10,
    'b' => 5
]);

// Print the response
print_r($response);
```


### Error Handling

```php
use APIVerve\Math\Client;
use APIVerve\Math\Exceptions\APIException;
use APIVerve\Math\Exceptions\ValidationException;

try {
    $response = $client->execute(['operation' => 'add', 'a' => 10, 'b' => 5]);
    print_r($response['data']);
} catch (ValidationException $e) {
    echo "Validation error: " . implode(', ', $e->getErrors());
} catch (APIException $e) {
    echo "API error: " . $e->getMessage();
    echo "Status code: " . $e->getStatusCode();
}
```

### Debug Mode

```php
// Enable debug logging
$client = new Client(
    apiKey: 'YOUR_API_KEY',
    debug: true
);
```

## Example Response

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

## Requirements

- PHP 7.4 or higher
- Guzzle HTTP client

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/math?utm_source=packagist&utm_medium=readme).

## Support

- Website: [https://apiverve.com/marketplace/math?utm_source=php&utm_medium=readme](https://apiverve.com/marketplace/math?utm_source=php&utm_medium=readme)
- Email: hello@apiverve.com

## License

This package is available under the [MIT License](LICENSE).
