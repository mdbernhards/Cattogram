//Table users
//{
//    id integer [primary key]
//    username varchar
//  password_hash varchar
//  email varchar
//  role varchar
//  created_at timestamp
//}

//Table follows
//{
//    following_user_id integer
//  followed_user_id integer
//  created_at timestamp
//}

//Table posts
//{
//    id integer [primary key]
//    user_id integer
//  title varchar
//  body text [note: 'Content of the post']
//    status varchar
//  created_at timestamp
//}

//Table photos
//{
//    id integer [primary key]
//    post_id integer
//  title varchar
//  photo_url varchar
//  status varchar
//  created_at timestamp
//}

//Table comments
//{
//    id integer [primary key]
//    commenter_id integer
//  post_id integer
//  text varchar
//  status varchar
//  created_at timestamp
//}

//Table likes
//{
//    id integer [primary key]
//    liker_id integer
//  post_id integer
//  like_type_id text
//  status varchar
//  created_at timestamp
//}

//Table like_types
//{
//    id integer [primary key]
//    name varchar
//  created_at timestamp
//}

//Ref: users.id < follows.following_user_id

//Ref: users.id < follows.followed_user_id

//Ref: posts.user_id > users.id

//Ref: posts.id > photos.post_id

//Ref: comments.commenter_id > users.id

//Ref: comments.post_id > posts.id

//Ref: likes.liker_id > users.id

//Ref: likes.post_id > posts.id

//Ref: likes.like_type_id > like_types.id