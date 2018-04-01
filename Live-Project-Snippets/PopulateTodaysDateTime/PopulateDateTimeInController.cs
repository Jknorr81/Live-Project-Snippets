
// GET: Reviews/Create
public ActionResult Create()
{
    ViewBag.BuyerId = new SelectList(db.Buyers, "BuyerId");
    Review review = new Review();
    review.ReviewDate = DateTime.Now;
    return View(review);
}

// POST: Reviews/Create
// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create([Bind(Include = "ReviewID,ReviewDate,ProductRating,ReviewDetails,BuyerId")] Review review)
{
    try
    {
        if (ModelState.IsValid)
        {
            review.ReviewID = Guid.NewGuid();
            db.Reviews.Add(review);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }