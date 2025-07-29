string input = "In a quiet village nestled between rolling hills and whispering forests, there lived 1 man named Eliot who believed in the power of simplicity. Unlike the busy cities beyond the horizon, this village thrived on tradition, community, and the steady rhythm of nature. Eliot’s days began with the soft crow of a rooster and the golden light of sunrise spilling over the rooftops. He worked as a carpenter, shaping wood into furniture with care, using skills passed down through generations.\n\nThough he had never traveled far, Eliot’s mind was vast. He often read old books by candlelight, pondering the mysteries of stars, the patterns in leaves, and the stories behind every face he met. The villagers would gather around him in the evenings, drawn not only by his craftsmanship but also by his gentle wisdom. Children listened to his tales of mythical creatures and faraway lands, while the elders shared quiet nods of agreement to his thoughts about life’s deeper meanings.\n\nOne autumn, a traveler arrived in the village, bringing news of the outside world—of machines, inventions, and speed. Some villagers were intrigued, but Eliot remained rooted. He welcomed change but never abandoned his belief that slow, thoughtful living had its place. In time, the traveler left, but Eliot’s message stayed: progress is not just about how fast we move, but how deeply we connect—to each other, to our work, and to the world around us.\n\nSo the village continued, blending old ways with new ideas. And Eliot, under the same sun and sky, carved not only wood—but also a legacy of peace, purpose, and balance in a changing world.";

int vowelCount = input.Count(c => "aeiouAEIOU".Contains(c));
Console.WriteLine($"Total vowels: {vowelCount}");

int consonantCount = input.Count(c => char.IsLetter(c) && !"aeiouAEIOU".Contains(c) && !char.IsWhiteSpace(c) && !char.IsDigit(c));
Console.WriteLine($"Total consonants: {consonantCount}");

int digitCount = input.Count(c => char.IsDigit(c));
Console.WriteLine($"Total Digit: {digitCount}");

int totalCount = input.Count(c => char.IsLetter(c) && !char.IsWhiteSpace(c) || char.IsDigit(c));
Console.WriteLine($"Total charecter: {totalCount}");

