odata-opentypes
===============

Messing with open types for client and server


Server
=====

Definition
-----

In this particular scenario, the definition includes a person, who has "ExtraFields", which is itself a dictionary/open type. In the typical OData expected output, the property encapsulating the extra properties ("ExtraFields") is not serialized.

In accord with the code I built, I had to create a complex type that has no shape, which the client must then fill in.

I will later revisit whether or not it is possible to simply enable OData to serialize the dynamic properties property name (which would make this hack much simpler and less convoluted)

Client
=====

Using OData client code generator.
