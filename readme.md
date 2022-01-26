# Tafs.Activities

This library contains multiple resources for use with UiPath and other RPA activities. This document will provide a brief overview of the available resources, though for more information, the readme for the specific projects should be viewed.

## Directories

* Tests: All of the test libraries for each of the production resources.
* Experimental: Non-production-ready resources, either incomplete, unstable, or both.
* Experimental/Tests: Test libraries for the experimental resources, if available.

All production-ready resources will have proper test coverage. Experimental resources are not guaranteed to have any tests, nor are they guaranteed to necessarily pass any existing tests.

## Resources

* Tafs.Activities.ActivityBase - Provides common base types for asynchronous UiPath activities.
* Tafs.Activities.Results - Provides a wrapper for results and various error conditions.
* Tafs.Activities.Serialization - Provides types to facilitate serialization and deserialization.