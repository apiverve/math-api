# Math Calculator API - Ruby Gem

Math Calculator performs mathematical operations including arithmetic, number properties, base conversions, and expression evaluation.

## Installation

Add this line to your application's Gemfile:

```ruby
gem 'apiverve_math'
```

And then execute:

```bash
$ bundle install
```

Or install it yourself as:

```bash
$ gem install apiverve_math
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```ruby
require 'apiverve_math'

# Initialize the client
client = APIVerve::Math::Client.new(api_key: "YOUR_API_KEY")

# Make a request
response = client.execute({
  operation: "add",
  a: 10,
  b: 5
})

# Print the response
puts response
```


### Error Handling

```ruby
begin
  response = client.execute({ operation: "add", a: 10, b: 5 })
  puts response["data"]
rescue APIVerve::Math::ValidationError => e
  puts "Validation error: #{e.errors.join(', ')}"
rescue APIVerve::Math::APIError => e
  puts "API error: #{e.message}"
  puts "Status code: #{e.status_code}"
end
```

### Debug Mode

```ruby
# Enable debug logging
client = APIVerve::Math::Client.new(
  api_key: "YOUR_API_KEY",
  debug: true
)
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

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/math?utm_source=rubygems&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/math?utm_source=ruby&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/math?utm_source=ruby&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This gem is available under the [MIT License](LICENSE).
