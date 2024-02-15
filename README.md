# Blog API

## Overview

This ASP.NET Core API serves as the backend for a dynamic blog platform. It leverages C#, Entity Framework Core, and SQLite for efficient CRUD operations on blog posts, images, and categories. The API also implements secure authentication and authorization using JWT tokens.

# Check out my [Portfolio💜](https://aaliyahm-portfolio.netlify.app/) 

## Features

-   **CRUD Operations:**

    -   Blog Posts (CRUD)
    -   Images (Create & Read)
    -   Categories (CRUD)

-   **Database**

    -   Sqlite
    -   Migrations using Entity Framework Core

-   **Authentication:**

    -   JWT Token-based authentication
    -   JWT Bearer for secure communication

-   **Authorization:**
    -   Admin-only access for Create, Update, and Delete operations

## API Endpoints

**BlogPosts**

-   GET {apiBaseUrl}/api/blogposts - Retrieve all blog posts.
-   GET {apiBaseUrl}/api/blogposts/{id} - Retrieve a specific blog post by ID.
-   PUT {apiBaseUrl}/api/blogposts/{id} - Admin-only update for a blog post.
-   POST {apiBaseUrl}/api/blogposts - Admin-only create a new blog post.
-   DELETE {apiBaseUrl}/api/blogposts/{id} - Admin-only delete a blog post.
    **Categories**
-   GET {apiBaseUrl}/api/categories - Retrieve all categories.
-   GET {apiBaseUrl}/api/categories/{id} - Retrieve a specific category by ID.
-   PUT {apiBaseUrl}/api/categories/{id} - Admin-only update for a - category.
-   POST {apiBaseUrl}/api/categories - Admin-only create a new category.
-   DELETE {apiBaseUrl}/api/categories/{id} - Admin-only delete a category.
    **Images**
-   GET {apiBaseUrl}/api/images - Retrieve all images.
-   POST {apiBaseUrl}/api/images - Admin-only upload a new image.
